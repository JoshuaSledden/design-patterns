<h1>Strategy Pattern</h3>
The strategy pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable.
Strategy lets the algorithm vary independantly from clients that use it.

<h2>UML class diagram</h2>
<img src="https://www.dofactory.com/images/diagrams/net/strategy.gif"/>

<h2>What does this mean?</h2>
<p>The strategy pattern allows for a class to be decoupled from any differing strategies used within its function.
We do this generally by creating an interface for a certain action which has concrete strategies derived from it.
  
This then allows the class to decide upon and call different strategies via the interface without having any dependency to the strategies themselves. It only depends on the interface.</p>

<h2>Written example</h2>
<p>In the written example provided I decided to create a <b>Player</b> class. This <b>Player</b> class will be able to perform an <b>Attack</b> function. 
However, the <b>Player</b> can specify a <b>Player Class</b>. These classes are showcased with the examples of <b>Warrior</b>, <b>Ranger</b> and <b>Mage</b>.

Each <b>Player Class</b> will differ in it's attack. These different attack types have their own damage calculation.
Using the Strategy Pattern we can create an <b>IAttacking</b> Interface and then create concrete strategies of <b>MeleeAttack</b>, <b>MagicAttack</b> and <b>RangeAttack</b> that have their own <b>Attack</b> methods contained within.

All we have to do then is pass the specified <b>IAttacking</b> Interface into the constructor of the Player depending on the <b>PlayerClass</b> we create.

<h3>Our example diagram</h3>
<img src="https://raw.githubusercontent.com/JoshuaSledden/design-patterns/master/strategy/Strategy-Pattern-Player.jpg" />
