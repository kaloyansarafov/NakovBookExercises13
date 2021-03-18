using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM
{
    class Program
    {
        enum State { NULL, S, SO, SOS, N, NA, NAN, NANO };

        static bool FindSOS(string text)
        {
            State state = State.NULL;
            foreach (var ch in text)
            {
                switch (state)
                {
                    case State.NULL:
                        if (ch == 'N')
                        {
                            state = State.N;
                        }
                        break;
                    case State.N:
                        if (ch == 'A')
                        {
                            state = State.NA;
                        }
                        else if (ch == 'N')
                        {
                            // same state
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;
                    case State.NA:
                        if (ch == 'N')
                        {
                            state = State.NAN;
                        }
                        else if (ch == 'A')
                        {
                            // same state
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;
                    case State.NAN:
                        if (ch == 'O')
                        {
                            state = State.NANO;
                            return true;
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;
                }
            }
            return false;
        }

        static int CountSOS(string text)
        {
            int count = 0;
            State state = State.NULL;
            foreach (var ch in text)
            {
                switch (state)
                {
                    case State.NULL:
                        if (ch == 'N')
                        {
                            state = State.N;
                        }
                        break;
                    case State.N:
                        if (ch == 'A')
                        {
                            state = State.NA;
                        }
                        else if (ch == 'N')
                        {
                            // same state
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;
                    case State.NA:
                        if (ch == 'N')
                        {
                            state = State.NAN;
                        }
                        else if (ch == 'A')
                        {
                            // same state
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;
                    case State.NAN:
                        if (ch == 'O')
                        {
                            state = State.NANO;
                            count++;
                            state = State.NULL;
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountSOS("aaaNANONANANO"));
        }
    }
}