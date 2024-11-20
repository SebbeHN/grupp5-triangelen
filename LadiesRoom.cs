namespace One_night_at_Triangelen;

public class LadiesRoom:Location
{
    
    public LadiesRoom(Player player):base(player)
    {
        Description = "ladies room bottle wine and roses.";
        _menu = new Menu(this);
    }

    public override void HandleResponse(string response)          
    {                                                    
        switch (response)                                
        {                                                
            case("exit"):                           
                Console.WriteLine("exiting");       
                new SecondFloor(_player);                       
                break;                       
            case("drink booze"):
                Console.WriteLine("Glug glug glug");
                new LadiesRoom(_player); // unnecesary...
                // _menu.PrintOptions();
                break;
        }                                                
    }      
}