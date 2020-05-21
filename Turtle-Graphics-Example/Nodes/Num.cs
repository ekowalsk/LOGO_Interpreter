public class Num : IAST
{
    public string value { get; private set; }
    public Num(Token t)
    {
        value = t.getValue();
        output = null;
    }
    public void accept(IVisitor v)
    {
        v.visit(this);
    }
    public dynamic output { get; set; }
}