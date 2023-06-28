public abstract class Goal{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points){
        _name = name;
        _description = description;
        _points = points;
    }
    public abstract string RecordEvent();
    public abstract string IsComplete();
    public abstract string ExtractData();
    public string GetName(){
        return _name;
    }
    public string GetDescription(){
        return _description;
    }
    public int GetPoints(){
        return _points;
    }
}