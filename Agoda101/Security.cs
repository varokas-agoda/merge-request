
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
                case "Leee":
                    return true;
                case "Nir":
                    return true;
                default:
                    return false;
            }
        }
    }
}
