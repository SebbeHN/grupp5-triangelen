namespace One_night_at_Triangelen;

public class FirstFloor:Location
{
    public FirstFloor(Player player):base(player)
    {
        Description = "Here is the first floor. You can enter the escallator or go out. What do you want to do?";
        _menu = new Menu(this);
    }
    
    public override void HandleResponse(string response)
    {
        switch (response)
        {
            case("enter escallator"):
                new Escallator(_player);
                break;
            case("go out"):
                new Outside(_player);
                break;
        }
    }
}