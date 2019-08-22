== Example ==
    // Input:
    2       // number of commands
    2 1     // 'S'tarting vertex
    E 2     // command 1 to 'M'ove
    N 1     // command 2 to 'M'ove
    // Output:
    Cleaned: 4

    // Graph Output: S + (3 * M)
    xxxxxxx
    xxxxMxx
    xxSMMxx
    xxxxxxx


== Ideas ==
    Optimized data-type for unique values:
        HashSet<T> where T is struct => Vertex(int, int)
    
    Robot movement:
        Robot.Move(Command command)
        // includes current
        // includes passed

== TODO ==
	*! Add Dependency Injection
	* Change input validation model to DataAnnotations.
	* Add input validation to Application level.
