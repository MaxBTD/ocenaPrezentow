namespace sprawPrezenty
{
    internal class Program
    {
        public static char[] samogloski = { 'a', 'e', 'y', 'u', 'i', 'o' };
        static private bool czyPrezentPopraw(string prezent)
        {
            int samoCount = 0;
            if (prezent.Contains("ab") || prezent.Contains("cd") || prezent.Contains("yz"))
                return false;

            for(int i = 0; i < prezent.Length; i++){
                if (i + 1 < prezent.Length)
                    if (prezent[i] == prezent[i + 1])
                        return true;

                if (samogloski.Contains(prezent[i]))
                    samoCount++;
            }

            return samoCount >= 3 ? true : false;
        }
        static void Main(string[] args)
        {
            List<bool> popPrezent = new List<bool>();
            int.TryParse(Console.ReadLine(), out int n);

            for(int i = 0; i < n; i++){
                popPrezent.Add(czyPrezentPopraw(Console.ReadLine()));
            }

            for(int i = 0; i < n; i++){
                Console.WriteLine(popPrezent[i] ? "TAK" : "NIE");
            }
        }
    }
}
