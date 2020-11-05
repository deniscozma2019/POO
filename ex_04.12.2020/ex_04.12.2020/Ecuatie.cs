using System;

public class Ecuatie
{
	public Ecuatie()
	{
		double a, b, c;
		double A, B, C;
		A = a;
		B = b;
		C = c;

	}
	public double A, B, C {get;set;}
 

public int validecuatie()//validarea ecuatiei
{
	if (A > 0)
	return true;
else
	return false;
	
}

public double Delta()
{
	return (int)(Math.Pow(B, 2) - 4 * A * C);//calcularea deltei
}
public double Radical1()
{
	if (validecuatie() && Delta() > 0)
		return (double)Math.Round((-B - Math.Sqrt(Delta())) / (2 * A), 2);
	else
		return 0;
}

private double Radical2()
{
	if (isValidEcuation() && Delta() > 0)
		return (double)Math.Round((-B + Math.Sqrt(Delta())) / (2 * A), 2);
	else
		return 0;
	
}
public  double solutie()
{
	if (Delta() > 0 && validecuatie())
		return "2";
	else if (Delta() == 0)
		return "1";
	else
		return "0";
}
public void rezultat()
	List<String> valueList = new List<String>();

valueList.Add(" " + A.ToString() + "\t");
valueList.Add(B.ToString() + "\t");
valueList.Add(C.ToString() + "\t");
valueList.Add(Radical1().ToString() + "\t");
valueList.Add(Radical2().ToString() + "\t");
valueList.Add(solutie() + " ");

string[] line = new string[6];
for (int i = 0; i < valueList.Count; i++)
{
	line[i] += valueList[i];
}
table.Rows.Add(line);
