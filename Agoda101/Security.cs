
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
                case "Rambo":
                case "Bruce Lee":
                    return true;
                default:
                    return false;
            }
        }
    }
}
