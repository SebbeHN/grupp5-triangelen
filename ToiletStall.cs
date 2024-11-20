namespace One_night_at_Triangelen;

public class ToiletStall:Location
{
    
    public override void HandleResponse(string response)          
    {                                                    
        switch (response)                                
        {                                                
            case("open door"):                           
                Console.WriteLine("opening door");       
                new LadiesRoom(_player);                        
                break;                   
            case("check pockets"):
                _player.Inventory.Print();
                new ToiletStall(_player);
                break;
        }                                                
    }                                                    
    
    public ToiletStall(Player player):base(player) // constructor
    {
        Description = "Your head is hurting: hangover.";
        _menu = new Menu(this);
    }
    
}