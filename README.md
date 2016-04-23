# ReputationTitle
Generates a reputation title as-seen inthe game Ultima Online (uses same algorithm and titles).  C# static class.  .Net Core / 4.5  

In the game Ultima Online, players had a title that reflected their karma and fame.  For instance, a player with a long history of good deeds may have the title of 'Glorious' while a character with a long history of evil acts may have the title 'Dread Lord'.  This static class accepts karma and fame inputs and returns an appropiate title.  

This class is useful for developers that wish to implement a similair reputation system.  Karma range is below -10,000 to above 10,000 (after the extremes it stops mattering).  Fame is from 0 to 10,000-- again, post extremes doesn't change anything.

See the following for details: http://uo2.stratics.com/reputation/fame-and-karma-reputation-titles/
