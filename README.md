# NHLStatsSimulator
Interactive GUI to output goals as readable data into excel database.

Program is hard coded with "team canada" and "team U.S.A" for testing purposes. Importing teams from pre-existing databases exists in another version.
Program allows for exports of goals using shot coordinates, assist coordinates, goals for and against, players on ice as well as there +/-. 
Penalty functionality added as well.

The program is fully object oriented with classes for managing the list views (ListViewManager. The penalty timers (penTimer) and game timer (TimerForm).

The ListViewmanager class allows drag and drop features of player entities between team and on-ice listviews. 
The class allows drag and drop features to add and remove players from the roster/bench to on ice status.
Goal events will record players on ice/penalty box as well as all relevant information for exported data.
The goal menu allows information to be recorded with regards to a goal, coordinates for goal and assist can be locked with the most recent click on the rink.
The game timer allow start and stop functionality as well as the ability to jump to any custom time in the game. The game timer works in sync with penalty timers.
