# Civilization of Makudians  - physics features of new updated to be published 
### A Physics-Based Third-Person Simulation Environment Using Unity  

**Author:** Chamuditha Dissanayake  
BSc (Hons) Physics — University of Ruhuna  

---

## Abstract  
This work presents the development of a physics-based third-person interactive simulation environment using Unity and C#. The system integrates real-time rigid body dynamics, simplified fluid interaction, and environment-driven constraints to model physically consistent character behavior. The project demonstrates the application of classical mechanics principles within an interactive computational framework.

---

## 1. Introduction  
Game engines provide powerful platforms for real-time simulation of physical systems. This project explores the implementation of classical mechanics within a third-person environment, focusing on realistic motion, environmental interaction, and dynamic state transitions.  

The system builds upon a previously published single-player version (Google Play, April 2022) and extends it with improved physics modelling and multiplayer functionality.

---

## 2. System Architecture  
The simulation is implemented using Unity's Rigidbody physics engine. The system consists of:

- Force-based motion control  
- Velocity-driven state transitions  
- Environment-triggered physical responses  
- Multiplayer synchronization using Photon PUN  

---

## 3. Physics Modelling  

### 3.1 Rigid Body Dynamics  
Player motion is governed by Newtonian mechanics using velocity and force interactions. Movement direction is aligned with camera orientation to maintain intuitive control.

---

### 3.2 Buoyancy Model  
A simplified buoyancy force is applied:

**Equation:**  
F_b = mg  

```csharp
float buoyancyForce = 9.81f * rb.mass;
rb.AddForce(Vector3.up * buoyancyForce, ForceMode.Force);
```

### 3.3 Swimming Dynamics

Swimming combines buoyancy with user-controlled velocity input, allowing vertical motion (diving and surfacing) and horizontal navigation.


### 3.4 Drag and Damping

Fluid resistance is approximated using velocity damping:
```csharp
rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y * 0.9f, rb.velocity.z);

```
This models gradual energy dissipation in fluid environments.

Jumping is implemented using impulse forces:

```csharp
rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
```
This represents instantaneous force application.

### 3.6 Climbing Constraints

Climbing overrides gravity by enforcing controlled vertical motion:
```csharp
rb.velocity = new Vector3(rb.velocity.x, climbSpeed * vertical, rb.velocity.z);
```

### 3.7 Dynamic Collision Geometry

The character collider dynamically adapts to different states such as crouching, crawling, and swimming, improving collision accuracy.



4. Environmental Interaction

The system incorporates environment-dependent effects:
	•	Water regions enabling buoyancy and swimming
	•	Deep water zones imposing survival constraints
	•	Hazard regions (e.g., poison water) causing continuous damage



5. Results and Discussion

The system demonstrates stable real-time physics simulation with smooth transitions between multiple movement states. The simplified models provide computational efficiency while maintaining physical plausibility.



6. Future Work

Future developments include:
	•	Advanced fluid dynamics modelling
	•	Improved drag and turbulence simulation
	•	Enhanced multiplayer synchronization
	•	AI-driven physics interactions



7. Conclusion

This project highlights the application of computational physics principles within interactive environments. It demonstrates the potential of game engines as tools for real-time physical simulation and visualization.



Reference

previously Published Version:
https://play.google.com/store/apps/details?id=com.makudi.Com&pcampaignid=web_share
