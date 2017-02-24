namespace Interpreter
{
    public class WheatBread : IBread
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format(" {0} ", "Wheat-Bread");
        }
    }
}