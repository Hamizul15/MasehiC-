using Masehi.Equipment;
using Masehi.Initializer;

namespace Masehi.Masehi
{
    class Masehi_
    {
        Initializer_ initializer_;
        const string approvalType = "1";

        public Masehi_()
        {
            this.initializer_ = new Initializer_();
            Running();
        }

        public void Running()
        {
            string userChoice;
            do
            {
                initializer_.UserOption();
                userChoice = Tools.GetText("\n--> Continue(Type 1) or Stop(Type something): ");
            }
            while (userChoice.Equals(approvalType));
        }
    }
}
