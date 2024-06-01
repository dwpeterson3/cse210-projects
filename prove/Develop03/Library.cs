class Library
{
    private List<Scripture> _scriptures;

    public Library()
    {
        _scriptures = [
            new Scripture(new Reference("2nd Nephi", 2, 6, 7), "Wherefore, redemption cometh in and through the Holy Messiah; fore he is full of grace and truth. Behold, he offereth himself a sacrifice for sin, to answer the ends of the law, unto all those who have a broken heart and a contrite spirit; and unto none else can the ends of the law be answered."),
            new Scripture(new Reference("D&C", 130, 21),"And when we obtain any blessing from God, it is by obedience to that law upon which it is predicated."),
            new Scripture(new Reference("1st Conrinthians", 15, 22), "For as in Adam all die, even so in Christ shall all be made alive."), 
            new Scripture(new Reference("Alma", 38, 11, 12),"See that ye are not lifted up unto pride; yea, see that ye do not boast in your own wisdom, nor of your much strength. Use boldness, but not overbearance; and also see that ye bridle all your passions, that ye may be filled with love; see that ye refrain from idleness.")
        ];
    }


    public Scripture ScriptureGenerator()
    {
        Random rnd = new Random();

        int index = rnd.Next(_scriptures.Count);
        return _scriptures[index];
    }
}