namespace Oracle
{
    public record Hero(
        string Name,
        string Eye,
        string Alive,
        string Appearances,
        string First,
        string Appearance,
        string Hair,
        string Sex,
        string Align,
        string Id,
        string Secret);

    public record Registration(
        string Name,
        string Secret);

    public record PlanAction(
        string Hero,
        string Location,
        string Action);

    public record Event(
        string Type,
        string Location,
        int Strength);
}