# Bureaucratic Apparatus
Simulation of the work of the bureaucratic apparatus

Bureaucratic apparatus: citizens address cases to bureaucrats who solve certain types of issues, and they solve them indefinitely or refer them to others; if they decide for a long time, then citizens go to others, etc. each case ends only after solving a certain number of different types of issues or with the refusal of a citizen to solve the case

## Program window
![image](https://user-images.githubusercontent.com/109802024/216967136-56ae22e8-0c6f-4938-8985-05c7b221734b.png)

## Program features:
- If a bureaucrat is unable to solve the issue, a citizen goes to another bureaucrat
- When solving a sufficient number of questions (a random variable from 1 to 5), the case is considered completed
- When solving cases, a citizen with a probability of 20% can refuse to solve the case. In this case, the case is marked as completed and is not considered further
- A bureaucrat can refuse to solve a case with a probability of 45%
- The protocol of the threads (log) occurs in the critical section of code

## The fragment of the protocol of the threads (log)
![image](https://user-images.githubusercontent.com/109802024/216967618-a9149eca-be3d-46df-8615-cb2ed9574697.png)
