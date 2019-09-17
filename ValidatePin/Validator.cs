using System;

namespace Validate.Pin
{
    public class PinValidator
    {
        //Responsible for checking if pin has any punctuation.
        public bool HasPunctuation(string pin)
        {
            //Returns false has soon has any non-digit is found.
            foreach (char c in pin)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public bool ValidatePin(string pin)
        {
            //Starts by checking pin's length.
            if (pin.Length != 4 && pin.Length != 6)
            {
                return false;   //If invalid, false.
            }
            //Else, is within requested
            else
            {
                if (!HasPunctuation(pin))       //If pin has punctuation...
                {
                    return false;               //Returns false.
                }
            }

            return true;
        }
    }
}