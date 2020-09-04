#include "pch.h"

using namespace winrt;
using namespace Windows::Foundation;
using namespace MyRandom;

int main()
{
    init_apartment();

    NumberGenerator numGenerator;
    printf("Unbounded Number     : %d\n", numGenerator.GetInteger());
    printf("Bounded Number (0,10): %d\n", numGenerator.GetInteger(0, 100));

    MessageOfTheDayGenerator messageOfTheDayGenerator;
    printf("Message: %ls\n", messageOfTheDayGenerator.MessageOfTheDay().c_str());
}
