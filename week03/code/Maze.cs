
public class Maze {
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    private readonly int _LEFT = 0;
    private readonly int _RIGHT = 1;
    private readonly int _UP = 2;
    private readonly int _DOWN = 3;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap) {
        _mazeMap = mazeMap;
    }


    public void MoveLeft() {
      
        if (_mazeMap[(_currX, _currY)][_LEFT])
        {
            _currX--;
            Console.WriteLine($"Moving left to ({_currX}, {_currY}).");
        }
        else{
            Console.WriteLine("Can't move that way!");
        }
    }

 
    public void MoveRight() {

        if (_mazeMap[(_currX, _currY)][_RIGHT])
        {
            _currX++;
            Console.WriteLine($"Moving right to ({_currX}, {_currY}).");
        }
        else{
            Console.WriteLine("Can't move that way!");
        }
    }
      

    public void MoveUp() {
        
        if (_mazeMap[(_currX, _currY)][_UP])
        {
            _currY--;
            Console.WriteLine($"Moving up to ({_currX}, {_currY}).");
        }
        else{
            Console.WriteLine("Can't move that way!");
        }
    }
     
    public void MoveDown() {
        // FILL IN CODE
        if (_mazeMap[(_currX, _currY)][_DOWN])
        {
            _currY++;
            Console.WriteLine($"Moving down to ({_currX}, {_currY}).");
        }
        else{
            Console.WriteLine("Can't move that way!");
        }
    }

    public void ShowStatus() {
        Console.WriteLine($"Current location (x={_currX}, y={_currY})");
    }
}