public class hanoi {
 
private static void calcHanoi(int src, int dst, int n)
{
int helper = 6 - (src + dst);  
 
if (n == 1)
System.out.println(src + " => " + dst);
else {
calcHanoi(src, helper, n-1);
calcHanoi(src, dst, 1);
calcHanoi(helper, dst, n-1);
}
}
 
public static void main(String[] args) {
int i;
 
System.out.println("1 - palik zrodlowy");
System.out.println("2 - palik pomocniczy");
System.out.println("3 - palik docelowy");
i = Console.readInt("Ile krazkow przeniesc? ");
 
calcHanoi(1, 3, i);
}
}