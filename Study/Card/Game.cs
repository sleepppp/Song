
/* class Game
 * 용도 :
 * 역할 : 
 * 왜 굳이 class로 만들었을까? 
 */
class Game
{
    private Card[] cards = new Card[52];
    private int gameCount;

    public void Init(int inGameCount)
    {
        gameCount = inGameCount;

        for (int i = 0; i < cards.Length; i++)
        {
            cards[i] = new Card();
            cards[i].Init(i % 13 + 1, (Symbol)(i / 13));
        }
        Random random = new Random();

        for (int i = 0; i < 100; i++)
        {
            int randomIndexA = random.Next(cards.Length);
            int randomIndexB = random.Next(cards.Length);

            Card temp = cards[randomIndexA];
            cards[randomIndexA] = cards[randomIndexB];
            cards[randomIndexB] = temp;
        }
    }

    public void Run()
    {
        int tempIndex = 0;
        for (int i = 0; i < gameCount; ++i)
        {
            Card firstCard = cards[tempIndex];
            firstCard.Print();
            
            tempIndex++;
            Card secondCard = cards[tempIndex];
            secondCard.Print();
           
            tempIndex++;
            Card thirdCard = cards[tempIndex];
            tempIndex++;
        }

        //for (int i = 0; i < cards.Length; i++)
        //{
        //    cards[i].Print();
        //}
    }
}