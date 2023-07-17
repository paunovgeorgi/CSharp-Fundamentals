int numOfPeople = int.Parse(Console.ReadLine());
int capacity = int.Parse(Console.ReadLine());

int numOfCourses = (numOfPeople / capacity);
if (numOfPeople % capacity != 0)
{
    numOfCourses += 1;
}
Console.WriteLine(numOfCourses);