using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300092
{
    public enum State { Terkunci, Terbuka };
    public enum Trigger { KunciPintu, BukaPintu };
    class Transition
    {
        public State langkah1;
        public State langkah2;
        public Trigger triger;

        public Transition(State langkah1, State langkah2, Trigger triger)
        {
            this.langkah1 = langkah1;
            this.langkah2 = langkah2;
            this.triger = triger;
        }

    }
    class DoorMachine
    {
        public static List<Transition> transition = new List<Transition>
             {
                 new Transition(State.Terkunci,State.Terbuka,Trigger.BukaPintu),
                 new Transition(State.Terkunci,State.Terkunci,Trigger.KunciPintu),
                 new Transition(State.Terbuka, State.Terkunci, Trigger.KunciPintu)
             };

        public State current;

        public DoorMachine()
        {
            current = State.Terkunci;
            Console.WriteLine("Pintu Terkunci");
        }
        public State GetLangkah2(State langkah1, Trigger triger)
        {
            foreach (var transition in transition) 
            {
                if (transition.langkah1 == langkah1 && transition.triger == triger)
                {
                    return transition.langkah2;
                }
            }
            return langkah1;
        }

        public void ActivateTrigger(Trigger triger)
        {
            State nextState = GetLangkah2(current, triger);
            if (nextState != current)
            {
                current = nextState;
                Console.WriteLine(nextState == State.Terkunci ? "Pintu terkunci "
                    : "Pintu tidak terkunci");
            }
        }

    }
}
