using System;

public class Block
{
    //Поля сторін
    public int SideA { get; set; }
    public int SideB { get; set; }
    public int SideC { get; set; }
    public int SideD { get; set; }

    //Конструктор
    public Block(int sideA, int sideB, int sideC, int sideD)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
        SideD = sideD;
    }

    //Перевизначаємо метод
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType()) return false;

        Block other = (Block) obj;

        return SideA == other.SideA &&
            SideB == other.SideB &&
            SideC == other.SideC &&
            SideD == other.SideD;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(SideA, SideB, SideC, SideD);
    }
    public override string ToString()
    {
        return $"Block: A = {SideA}, B = {SideB}, C = {SideC}, D = {SideD}";
    }

}
