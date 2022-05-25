# Orbital-2022-That-s-Life-5288-
![](RackMultipart20220525-1-y4ehis_html_19bc63fa24c5880f.png)

**MILESTONE 1 SUBMISSION**

**Team Name**

That&#39;s life

**Proposed Level of Achievement**

Apollo 11

**Motivation**

We are fans of games where our choices have an impact on how the story progresses, and can lead to multiple different outcomes. These kinds of games have a high replayability as the number of paths are usually exponential and hence, by selecting a different choice at a certain stage, you will end up at a different state. It is not very intensive, and we like the fact that you can play them while on the go.

We would also like to use this as an opportunity to utilise data structures such as queues and look into randomisation algorithms to create a working game. This also exposes us to the facets of game-making and user interface optimisation.

Once the game skeleton has been implemented, the theme can be changed easily and events altered to more specific roles, such as to raise awareness or provide deeper insights into certain pathways, such as a teacher/artist/engineer simulator etc.

**Aim**

That&#39;s life will be a life simulator game, with users encountering randomly generated events that force them to make choices, with each of these choices affecting certain attributes such as charisma, fame, health and so on. At the end of the game, the total scores for each attribute are tallied and certain titles are awarded to the player based on their final scores. That&#39;s life is inspired by the mobile game Bitlife Simulator.

The user interface is planned to be done up in a style reminiscent of sketchbook doodles, with a mainly black and white colour scheme and illustrations portrayed using stick figures. There will be simple buttons for each choice available to the player to make to progress through the game, and the game&#39;s layout will be done in a portrait orientation. The individual game features will be described in greater detail in the other sections below.

The ultimate aim for That&#39;s life is for it to be a game that has many different possible outcomes in your game &quot;life&quot;, and we hope players will be driven to replay the game many times to achieve all the possible titles. We want it to be something you can play in your spare time anywhere, with each new game run not taking up a large time investment. We want to release That&#39;s life on the Google Play Store at the end of our project once all the features are included at a satisfactory standard, so that we can experience what the process is like to release an application on the Android platform. Since this experience is our main goal and we lack the resources for advertising, we are setting our goal to be 50 downloads.

**User Stories**

1. As a student who travels to and from school frequently by public transport, I want a way to pass my time while travelling that does not require me to be too involved.
2. As a collector, I want to collect every possible title in the game.
3. As a perfectionist, I want to try attaining the highest possible stats for the possible outcomes.
4. As a casual gamer, I want to play an engaging and interactive game where my choices matter.
5. As a speedrunner, I want to try attaining all the possible titles in the shortest time possible.
6. As a mobile gamer, I want something that is free-to-play, and has all its features available without being locked behind in-app transactions.
7. As a youth, I want to be able to see how some choices we make in life can have different types of impacts on our future.

**User Profiling**

After conducting some user profiling, we determined the general motivations of our target audience, along with the focus areas we should work on to address these motivations.

Motivations

1. A game to pass free time easily without requiring much effort or time investment.
2. A game where the players&#39; choices have a significant impact on the outcome.

Focus Areas

1. A user interface that can be played with one hand.
2. Short gameplay with save functionality.
3. A wide range of events with each of the choices made impacting the different attributes.

**Storyline**

Stages in life

1. Child
2. Teen
3. Young Adult
4. Adult
5. Elderly

| **Attributes** | **Achievement badges** |
| --- | --- |
| Career / Education | Word Junkie / Smooth Brain |
| Popularity | Social butterfly / Shut-In |
| Health | Peak Human / Zombie |
| Life Skills | Handyman / Hopelessly Inept |
| Morals | Saint / Villain |
| - | Jack of All Trades / Master of None |

Each new game starts from the child stage and each scenario encountered will &quot;age&quot; the character. Our preliminary estimation is that each &quot;phase of life&quot; will span 5 scenarios.

The user will be able to customise the name of the character and the character will start with a standardised 50 score for all attributes. The maximum attribute score is 100. Throughout the game, the attribute scores will be hidden from the player and will be revealed at the end along with the achievement that the player has.

**Scenarios**

Scenarios will be pulled randomly from a pool of events associated with a &quot;phase&quot; in life. Each event presents 2 - 4 options to the player. Each option will increase/decrease the attributes, but it is unknown to the player.

**Achievements**

Achievement title and badges are awarded from the final attribute tallies for that run. Eligibility for an achievement is decided by a predetermined cut-off for the attribute.

E.g. If a player achieved \&gt;80 for Life Skills, he would receive the title of (HandyMan) and have a handyman badge in his badge collection page.

**Child**

Focus for the scenarios

- Early days of a person&#39;s life
- First impressions about the surroundings
- Interactions with the people raising you

**Teen**

Focus for the scenarios

- Learning about yourself
- Social interactions with friends and the people around you

**Adult**

Focus for the scenarios

- Work-related interactions
- Providing for your family / being self-sufficient
- Juggling commitments

**Elderly**

Focus for the scenarios

- How you spend your golden years after retirement
- Attitude towards what you achieved over your life (being satisfied / bitter)
- Interactions with others now that you have plenty of free time and lesser commitments

**Features**

**Choice based advancement system**

**[Proposed]**

Our proposed game advancement system queues a set of scenarios that are pulled from 4 pools of scenarios that correspond to the different phases of life.

On creation of a character, the queued scenario will be extracted one by one and presented to the user. Each scenario presents several choices that increase different attributes, unknown to the user.

![Scenario Page](https://user-images.githubusercontent.com/88079008/170193727-e40caa47-378b-4b3e-b2ad-e0a729416482.png)

**Image 1: Sample scenario for teenager phase**

Upon making a choice, a page with a short summary of your choice and text that hints at what attributes were increased will be shown , before proceeding to the next scenario.

![](RackMultipart20220525-1-y4ehis_html_ffd1a240e66b35e8.png)

**Image 2: Sample summary text after each scenario**

When all the queued scenarios are exhausted the game is over and the attribute tally, achievement title and badge for that game run will be revealed to the player.

**[Current Progress]**

We have implemented a deterministic set of scenarios and explanations that automatically transitions to the next scene using Unity&#39;s Scene Management system. The events are triggered by the click of the corresponding button.

**Background attributes tracker**

**[Proposed]**

The creation of a new character will also have an associated attribute page with 5 attributes and each initialised to 50. From there, each scenario choice will alter the attributes behind the scenes.

This tracker runs in the background with the game and will be used to make the final ending screen, in which the achievement title and the final attributes of the character is displayed.

![](RackMultipart20220525-1-y4ehis_html_7aeaf38030d815d6.png)

**Image 3: Sample game summary page**

**[Current Progress]**

We have implemented a Player class that has corresponding attributes to keep track of the scores. We have also added a &quot;phase of life&quot; field that changes depending on how many scenarios the player has experienced.

For the proof of concept, we have set the length of each phase of life to be 2 scenarios. The statistics in the summary page are also automatically generated based on the current state of the player at the end of the run.

**Achievement badge collection page**

**[Proposed]**

The Achievement badge collection page can be accessed from the Main menu. It provides a storage / &quot;Hall of Fame&quot; concept where the badges that the player has collected will be showcased.

![](RackMultipart20220525-1-y4ehis_html_6cf7c37c22a71a94.png) ![](RackMultipart20220525-1-y4ehis_html_2f1be05ef810f1fc.png)

**Image 4: Sample Achievement badges page**

For each of the 5 attributes, we have 2 badges that indicate either exceedingly high / low achievement in a run. For example, for the Morals attribute, we have a Saint and a Villain badge. On top of that, there will be 2 badges (Jack of All Trades / Master of None) that are given out in a run where all attributes are exceedingly high / low.

This promotes replayability and encourages the user to play with the different choices in order to collect all the badges.

**[Current Progress]**

To be done in Milestone 2.

**User Interface, music**

**[Proposed]**

Players will be presented with the start page when the game is launched. The page will include the following buttons, which leads to their respective pages

**Start Page**

**Start New Game :** Start a new character which leads to the character naming page

**Load Saved Game :** Loads latest saved game

**Achievement Badges :**&quot;Hall of Fame&quot; style page that showcases the badges that the player has achieved

**History :** Collection of previous characters and achievements received for that character

**Settings :** Toggle the music/sound effects

The game will contain royalty-free music and in-game sound effects.

**In-Game Pause Menu**

**Continue :** Brings the game back to pre-pause state

**Save game :** Saves the current state of the game

**Settings :** Leads to setting page

**[Current Progress]**

We have implemented the Start new game button that brings you to the character naming page.

**Timeline and Development plan**

| **MS** | **Tasks** | **Description** | **Date** |
| --- | --- | --- | --- |
| 1 | User Interface and Game Elements design | Plan and design the layouts of the different pages (Main Menu, Scenarios, Achievements) | 12 - 17 May |
| Acquiring relevant knowledge for implementation | Looking into and deciding on features of Unity to use for implementation / data structures to support the scenario | 18 - 24 May |
| Button Mechanics | Implementing the various buttons needed in-game and transitioning to the appropriate pages when clicking the buttons | 25 - 28 May |
| Attribute Tracker | Keeping track of changes to the various attributes to tally up at the end of the game |
| Queue system for Scenarios | Unity Event management system for allocating scenarios to a player |
| Integration | Looking into scaling up for next milestone and simple testing | 28 - 30 May |
| **Evaluation Milestone 1:**
- Ideation
- Proof-of-concept
  - Start screen with start new game feature
  - 1 game route consisting of 1 scenario from each of the age periods
  - End screen created with stats from attribute tracker
 | 30 May |
| 2 | User Interface | Implement the button for the Achievement Badges page on the Main Menu | 31 May - 13 June |
| Achievement Badges page |
| Scenarios | Design and ideation for different scenarios | 31 May - 15 June |
| Scenario pools | Implementation of pools to separate different scenarios and look into randomization algorithms (Fisher-Yates shuffle) to allocate events | 13 - 24 June |
| Testing and Debugging | Preparation for submission of working prototype with testing and debugging | 25 - 27 June |
| Look into next milestone |
| **Evaluation Milestone 2: Prototype**
- Completion of the base game
  - Achievement system is put into place
  - Fully fleshed out pools of scenarios for each of the different age periods
 | 27 June |
| 3 | User Interface | Settings button | 28 June - 5 July |
| Save / Load game option |
| Sound options |
| Sound | In-game music and sound effects |
| History page | Shows the different runs by a player and the achievements in each run | 6 - 11 July |
| Scenario refinements and balancing | Rebalancing of attribute changes attached to each scenario if needed | 12 - 24 July |
| Look into possibility of chance scenarios to expand storyline |
| Keeping track of friends in each run to personalise scenarios |
| **Evaluation Milestone 3: Quality of Life Improvements**
- Save / Load game system
- Sounds effects and game music
- Tracking of game history
- Fine tuning and balancing the game
 | 25 July |
|
4 | Refinement and Bug-Testing | Ensure that all scenarios are balanced with reasonable difficulty to attain each achievement badge | 26 July - 14 August |
| Ensure that gameplay runs smoothly |
| Publishing | Look into publishing the game onto the Google Play Store | 15 - 23 August |
| **Splashdown: Refinement and Publishing** | 24 August |

**Proof of Concept**

**Work Log**

[https://docs.google.com/spreadsheets/d/1VVQywAAkrUjOAPJn56lE6Ipk3nJ3S170wanj3nepFFQ/edit?usp=sharing](https://docs.google.com/spreadsheets/d/1VVQywAAkrUjOAPJn56lE6Ipk3nJ3S170wanj3nepFFQ/edit?usp=sharing)
