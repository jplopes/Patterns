namespace Interpreter
{
    public class MayoCondiment : ICondiment
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format(" {0} ", "Mayo");
        }
    }
}