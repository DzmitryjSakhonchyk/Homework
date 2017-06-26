﻿using System;

namespace NumberSequence
{
    class NondecreasingNumberSequence
    {
        public bool MembershipCheck(int[] numberSequence)
        {
            bool check = true;
            for (int i = 1; i < numberSequence.Length; i++)
            {
                if (numberSequence[i] - numberSequence[i - 1] < 0)
                {
                    check = false;
                    break;
                }
                else
                {
                    check = true;
                }
            }
            return check;
        }
        
        public void ShowResult(bool membershipCheck)
        {
            const string YES = "\nThis number sequence is a nondecreasing number sequence.";
            const string NO = "\nThis number sequence is not a nondecreasing number sequence.";
            if (membershipCheck == true)
            {
                Console.WriteLine(YES);
            }
            else
            {
                Console.WriteLine(NO);
            }
        }
    }
}
