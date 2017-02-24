namespace Interpreter
{
    public class WhiteBread : IBread
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format(" {0} ", "White-Bread");
        }
    }
}