# bdsa-Assignment00

This is the handin for bdsa Assignment 00. Run in the terminal:
<ul>
    <li>Dotnet Build</li>
    <li>Dotnet Test</li>
    <li>Dotnet Run --project .\LeapYear\LeapYear.csproj</li>
</ul>

Here is a UML Diagram of the algorithm implemented to solve the problem (Some steps are removed since they are impossible to achieve, ie not being divisible by 4, yet being divisible by 400)
:::mermaid
flowchart LR;
    Start-->id1{Divisible By 4?}--Yes-->id2{Divisible 100?}--No-->id3(Leap Year)
    id1{Divisible By 4?}--No-->id4(Not Leap Year)
    id2{Divisible 100?}--Yes-->id5{Divisible 400?}--Yes-->id3(Leap Year)
    id5{Divisible 400?}--No-->id4(Not Leap Year)
:::
