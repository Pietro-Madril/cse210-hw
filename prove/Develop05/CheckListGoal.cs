public class CheckListGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;
    public CheckListGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountComplete = 0;
        _target = target;
        _bonus = bonus;
    }
    public override int RecordEvent()
    {
        if (_amountComplete < _target)
        {
            _amountComplete++;
            if (_amountComplete == _target)
            {
                return _points + _bonus;
            }
            return _points;
        }
        return 0;
    }
    public override bool IsComplete()
    {
        return _amountComplete >= _target;
    }
    public override string GetDetailsString()
    {
        return $"{_shortName} - {_description} (Completed {_amountComplete}/{_target})";
    }
    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{_shortName},{_description},{_points},{_amountComplete},{_target},{_bonus}";
    }
}
