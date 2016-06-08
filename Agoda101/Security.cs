
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
                case "Joel":
                    return true;
                default:
                    return false;
            }
        }
    }
}
