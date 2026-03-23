class Eternal : Goal
{

    public Eternal() : base () {}

    private int _count = 0;

    override public void RecordProgress()
    {
        _count += 1; 
    }


    public override bool Check()
    {
        return false;
    }
}
    