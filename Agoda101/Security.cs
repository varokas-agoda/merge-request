﻿
namespace Agoda101
{
    public class Security
    {
        public Security()
        {
        }

        public bool LetMeIn(string name)
        {
            switch (name)
            {
                case "Lee":
                    return true;
                case "Nir":
                    return true;
                default:
                    return false;
            }
        }
    }
}
