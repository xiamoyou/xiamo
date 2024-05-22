#include <iostream>

int main()
{
    double num1, num2;
    char op;

    std::cout << "请输入第一个数: ";
    std::cin >> num1;

    std::cout << "请输入运算符 (+,-,*,/): ";
    std::cin >> op;

    std::cout << "请输入第二个数: ";
    std::cin >> num2;

    switch (op)
    {
        case '+':
            std::cout << num1 << " + " << num2 << " = " << num1 + num2 << std::endl;
            break;
        case '-':
            std::cout << num1 << " - " << num2 << " = " << num1 - num2 << std::endl;
            break;
        case '*':
            std::cout << num1 << " * " << num2 << " = " << num1 * num2 << std::endl;
            break;
        case '/':
            if (num2 != 0)
            {
                std::cout << num1 << " / " << num2 << " = " << num1 / num2 << std::endl;
            }
            else
            {
                std::cout << "不能除以 0" << std::endl;
            }
            break;
        default:
            std::cout << "无效的运算符" << std::endl;
    }

    return 0;
}