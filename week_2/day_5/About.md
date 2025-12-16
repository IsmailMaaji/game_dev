<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Game Design Document</title>
    <style>
        body { font-family: Arial, sans-serif; line-height: 1.6; margin: 20px; }
        h1, h2, h3 { color: #2c3e50; }
        hr { border: 0; border-top: 1px solid #ccc; margin: 20px 0; }
        ul { list-style-type: disc; margin-left: 20px; }
        strong { color: #e74c3c; }
    </style>
</head>
<body>

<h1>Game Design Document</h1>
<hr>

<h2>One-Line Idea</h2>
<p>Players wander through dangerous areas to grab crystals and bring peace back.</p>

<h2>Game Design Breakdown</h2>
<p><strong>Goal:</strong> Gather all the crystals to put an end to the war between nations.</p>
<p><strong>Rules:</strong></p>
<ul>
    <li>Players lose health if they get hit by enemies.</li>
    <li>Crystals are protected and need to be collected in a certain order.</li>
</ul>
<p><strong>Feedback:</strong></p>
<ul>
    <li><strong>Success:</strong> When you collect a crystal, it glows and makes a sound.</li>
    <li><strong>Failure:</strong> Screen briefly flashes red with a dull hit sound and a health reduction indicator.</li>
</ul>
<p><strong>Rule Change & Experience Impact:</strong> If players can pick up the crystals in any order, the game feels more open and encourages strategic exploration instead of following a straight path.</p>

<hr>
<h2>Game Pillars (Feel Words)</h2>
<ul>
    <li>Exploration</li>
    <li>Tension</li>
    <li>Discovery</li>
</ul>
<p><strong>Non-Goal:</strong> No grinding or repetitive tasks to progress.</p>

<hr>
<h2>Core Mechanics & Intended Feelings</h2>
<ul>
    <li><strong>Exploration:</strong> Creates a feeling of freedom and curiosity.</li>
    <li><strong>Crystal Collection:</strong> Creates a feeling of achievement and progress.</li>
    <li><strong>Enemy Avoidance/Combat:</strong> Creates tension and danger.</li>
</ul>
<p><strong>Removing One Mechanic:</strong> If enemy avoidance/combat is removed, the game feels more calm and relaxing, shifting the experience toward pure exploration with less tension and challenge.</p>

<hr>
<h2>Core Game Loop</h2>
<p>Do <strong>Explore dangerous areas</strong> → Get <strong>Crystals</strong> → Unlock/Prepare <strong>New zones and upgrades</strong> → Repeat</p>

<h2>4-Step Progression (Teach / Test / Twist / Master) – New Mechanic: Dash Ability</h2>
<ul>
    <li><strong>Teach:</strong> Player learns dash in a safe area with no enemies.</li>
    <li><strong>Test:</strong> Player uses dash to avoid slow enemies and simple traps.</li>
    <li><strong>Twist:</strong> Dash now has a cooldown and must be timed to pass hazards.</li>
    <li><strong>Master:</strong> Player combines dash with enemy patterns and tight spaces under pressure.</li>
</ul>

<hr>
<h2>Goal</h2>
<p>Collect all crystals to restore peace between the nations.</p>

<h2>Rules</h2>
<ul>
    <li>The player loses health when hit by enemies.</li>
    <li>Crystals can only be collected after clearing or avoiding their guarded area.</li>
</ul>

<h2>Feedbacks</h2>
<ul>
    <li><strong>Success:</strong> Crystal emits a bright glow, a clear chime sound plays, and the UI shows progress.</li>
    <li><strong>Failure:</strong> Screen briefly flashes red with a dull hit sound and a health reduction indicator.</li>
</ul>

<h2>Cosmetic Reward</h2>
<p>Unlock a new glowing outfit color or crystal-themed aura after collecting a major set of crystals (milestone completion).</p>

<hr>
<h2>Fairness Tool</h2>
<p><strong>Invincibility frames after getting hit:</strong> Gives beginners a short safety window to recover and reposition, reducing frustration and unfair deaths.</p>

<h2>Tuning Knobs</h2>
<ul>
    <li><strong>Enemy damage:</strong> Lowering it early makes learning safer without removing challenge.</li>
    <li><strong>Crystal placement distance:</strong> Spreading crystals gradually encourages exploration without overwhelming new players.</li>
</ul>

<hr>
<h2>New Idea: Crystal Ruins Zone – 4-Room Layout</h2>

<h3>Room 1 – Introduction Room</h3>
<ul>
    <li><strong>Purpose:</strong> Teach the player the layout and dangers of the ruins.</li>
    <li><strong>Content:</strong> Few enemies, visible crystal in the distance.</li>
    <li><strong>Checkpoint:</strong> At the exit of the room.</li>
    <li><strong>Why:</strong> Saves time and reduces frustration if the player fails later.</li>
</ul>

<h3>Room 2 – Challenge Room</h3>
<ul>
    <li><strong>Purpose:</strong> Test enemy avoidance and movement.</li>
    <li><strong>Content:</strong> Multiple enemies guarding paths, simple traps.</li>
    <li><strong>Checkpoint:</strong> Before entering the next room.</li>
    <li><strong>Why:</strong> Prevents replaying the learning section repeatedly.</li>
</ul>

<h3>Room 3 – Twist Room</h3>
<ul>
    <li><strong>Purpose:</strong> Add a new twist (narrow paths or timed hazards).</li>
    <li><strong>Content:</strong> Enemies + environment hazards combined.</li>
    <li><strong>Checkpoint:</strong> Right before the crystal chamber.</li>
    <li><strong>Why:</strong> Reduces frustration before the most difficult section.</li>
</ul>

<h3>Room 4 – Reward Room (Crystal Chamber)</h3>
<ul>
    <li><strong>Purpose:</strong> Payoff and progression.</li>
    <li><strong>Content:</strong> Main crystal, strong visual effects, minimal danger.</li>
    <li><strong>Checkpoint:</strong> After collecting the crystal.</li>
    <li><strong>Why:</strong> Saves progress and reinforces success before moving on.</li>
</ul>

<hr>
<h2>Accessibility Features</h2>
<ul>
    <li><strong>Remappable controls:</strong> Available in the Settings menu from the main menu and pause screen.</li>
    <li><strong>High-contrast mode:</strong> Toggle option in Settings to make enemies, hazards, and crystals easier to see.</li>
</ul>

<h2>In-Game Prompt (Exact Text)</h2>
<p>“Hold <strong>SHIFT</strong> to dash through danger and avoid enemy attacks.”</p>

</body>
</html>
