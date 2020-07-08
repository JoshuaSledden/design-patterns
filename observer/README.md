<h1>Observer Pattern</h3>
The strategy pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. 

<h2>UML class diagram</h2>
<img src="https://www.dofactory.com/images/diagrams/net/observer.gif"/>

<h2>What does this mean?</h2>
<p>The Observer pattern allows a subject to attach observers to itself in order to effectively update them all whenever a state is changed.
This is better than an alternative of having the observing objects repeatedly requesting states from the Subject on a tick.</p>

<h2>Written example</h2>
<p>In the written example we created a simple <b>Item</b> abstract class. This abstract class holds all the methods for <b>Attach</b>, <b>Detach<b/> and <b>Notify</b>.
The abstract class also handles the individual <b>Name</b> and <b>Price</b> fields. The <b>Price</b> field will call <b>Notify</b> whenever the value is changed to something different.</p>
We then derive the concrete classes of <b>Toy</b> and <b>Book</b> as examples.

<p>Additionally we create an <b>ICustomer</b> interface. This interface declares the <b>Update</b> method. We then create a concrete class of <b>Customer</b> derived from this interface.
This class implements the functionality of the <b>Update</b> method.</p>

<p>So we initially create a new <b>Item</b> and allow a <b>Customer</b> to attach to it via the <b>Attach</b> method. Once the <b>Customer</b> is attached we can update
the <b>Item Price</b>. This will then call the <b>Notify</b> method which will then <b>Update</b> all attached <b>Customers</b> of the change in <b>Price</b>.

<h3>Our example diagram</h3>
<img src="https://raw.githubusercontent.com/JoshuaSledden/design-patterns/master/observer/observer-pattern.jpg" />
