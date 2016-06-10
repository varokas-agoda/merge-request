
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
                case "Tum":
                    return true;
                case "Nir":
                    return true;
                case "Mickey":
                    return true;
                default:
                    return false;
            }
        }
    }
}
