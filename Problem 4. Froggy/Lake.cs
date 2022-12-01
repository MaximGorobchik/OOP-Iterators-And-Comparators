using System.Collections;

public class Lake: IEnumerable<int>
{
    private List<int> stones;
    public Lake(List<int> stone)
    {
        this.stones = stone;
    }
    public IEnumerator<int> GetEnumerator()
    {
        for(int i=0;i<stones.Count;i+=2)
        {
            yield return this.stones[i];
        }
        var reversed = this.stones.Count - 1;
        if(this.stones.Count % 2 != 0)
        {
            reversed = this.stones.Count - 2;
        }
        for (int i = reversed; i > 0; i-=2)
        {
            yield return this.stones[i];
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
