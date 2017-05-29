using AutoTeleExchange.Classes;
using AutoTeleExchange.Enums;
using AutoTeleExchange.Interfaces;
using BillingSystem;
using BillingSystem.Classes;
using BillingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTeleExchange.Classes
{
    public class ATE : IATE
    {
        private IDictionary<int, Tuple<Port, IContract>> usersData;
        private IList<CallInfo> callList = new List<CallInfo>();
        public ATE()
        {
            usersData = new Dictionary<int, Tuple<Port, IContract>>();
        }

        public Terminal NewTerminal(IContract contract)
        {
            var newPort = new Port();
            newPort.AnswerEvent += CallingTo;
            newPort.CallEvent += CallingTo;
            newPort.EndCallEvent += CallingTo;
            usersData.Add(contract.Number, new Tuple<Port, IContract>(newPort, contract));
            var newTerminal = new Terminal(contract.Number, newPort);
            return newTerminal;
        }

        public IContract RegisterContract(User user, TypeOffTariffPlan type)
        {
            var contract = new Contract(user, type);
            return contract;
        }

        public void CallingTo(object sender, ICallEvent e)
        {
            if ((usersData.ContainsKey(e.TargetTelephoneNumber) && e.TargetTelephoneNumber != e.TelephoneNumber)
                || e is EndCallEvent)
            {

                CallInfo inf = null;
                Port targetPort;
                Port port;
                int number = 0;
                int targetNumber = 0;

                //1 EndCallEvent
                if (e is EndCallEvent)
                {
                    var callListFirst = callList.First(x => x.Id.Equals(e.Id));
                    if (callListFirst.SourceNumber == e.TelephoneNumber)
                    {
                        targetPort = usersData[callListFirst.TargetNumber].Item1;
                        port = usersData[callListFirst.SourceNumber].Item1;
                        number = callListFirst.SourceNumber;
                        targetNumber = callListFirst.TargetNumber;
                    }
                    else
                    {
                        port = usersData[callListFirst.TargetNumber].Item1;
                        targetPort = usersData[callListFirst.SourceNumber].Item1;
                        targetNumber = callListFirst.SourceNumber;
                        number = callListFirst.TargetNumber;
                    }
                }
                else
                {
                    targetPort = usersData[e.TargetTelephoneNumber].Item1;
                    port = usersData[e.TelephoneNumber].Item1;
                    targetNumber = e.TargetTelephoneNumber;
                    number = e.TelephoneNumber;
                }

                //2 IF 2 PORTS CONNECTED
                if (targetPort.Status == PortStatus.Connect && port.Status == PortStatus.Connect)
                {
                    var tuple = usersData[number];
                    var targetTuple = usersData[targetNumber];

                    //2.1 AnswerEvent
                    if (e is AnswerEvent)
                    {

                        var answerArgs = (AnswerEvent)e;

                        if (!answerArgs.Id.Equals(Guid.Empty) && callList.Any(x => x.Id.Equals(answerArgs.Id)))
                        {
                            inf = callList.First(x => x.Id.Equals(answerArgs.Id));
                        }

                        if (inf != null)
                        {
                            targetPort.AnswerCall(answerArgs.TelephoneNumber, answerArgs.TargetTelephoneNumber, answerArgs.InCall, inf.Id);
                        }
                        else
                        {
                            targetPort.AnswerCall(answerArgs.TelephoneNumber, answerArgs.TargetTelephoneNumber, answerArgs.InCall);
                        }
                    }

                    //2.2 CallEvent
                    if (e is CallEvent)
                    {
                        if (tuple.Item2.User.Money > tuple.Item2.Tariff.CostOfCallPerMinute)
                        {
                            var callArgs = (CallEvent)e;

                            if (callArgs.Id.Equals(Guid.Empty))
                            {
                                inf = new CallInfo(
                                    callArgs.TelephoneNumber,
                                    callArgs.TargetTelephoneNumber,
                                    DateTime.Now);
                                callList.Add(inf);
                            }

                            if (!callArgs.Id.Equals(Guid.Empty) && callList.Any(x => x.Id.Equals(callArgs.Id)))
                            {
                                inf = callList.First(x => x.Id.Equals(callArgs.Id));
                            }

                            if (inf != null)
                            {
                                targetPort.IncomingCall(callArgs.TelephoneNumber, callArgs.TargetTelephoneNumber, inf.Id);
                            }
                            else
                            {
                                targetPort.IncomingCall(callArgs.TelephoneNumber, callArgs.TargetTelephoneNumber);
                            }

                        }
                        else
                        {
                            Console.WriteLine("Terminal with number {0} is not enough money in the account!", e.TelephoneNumber);
                        }
                    }

                    // 2.3 EndCallEvent
                    if (e is EndCallEvent)
                    {
                        var args = (EndCallEvent)e;
                        inf = callList.First(x => x.Id.Equals(args.Id));
                        
                        if (Terminal.noAnswer == false)
                        {
                            inf.EndCall = DateTime.Now;
                        }
                        else inf.EndCall = inf.StartCall;

                        var sumOfCall = tuple.Item2.Tariff.CostOfCallPerMinute * (decimal)TimeSpan.FromTicks((inf.EndCall - inf.StartCall).Ticks).TotalMinutes;
                        inf.Cost = sumOfCall;
                        targetTuple.Item2.User.RemoveMoneyFromAccount(sumOfCall);
                        targetPort.AnswerCall(args.TelephoneNumber, args.TargetTelephoneNumber, CallStatus.Rejected, inf.Id);
                    }
                }
            }
            else if (!usersData.ContainsKey(e.TargetTelephoneNumber))
            {
                Console.WriteLine("This number is not in service.");
            }
            else
            {
                Console.WriteLine("You call your number.");
            }
        }

        public IList<CallInfo> GetInfoList()
        {
            return callList;
        }

    }
}
