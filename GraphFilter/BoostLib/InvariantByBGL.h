/*#ifndef MIXED_MODE_MULTIPLY_HPP
#define MIXED_MODE_MULTIPLY_HPP
#include <boost/lambda/lambda.hpp>
#include <iostream>
#include <iterator>
#include <algorithm>
using namespace std;

extern "C"
{
    __declspec(dllexport) int __stdcall boostTest(string g6) {
        using namespace boost::lambda;
        typedef std::istream_iterator<int> in;

        std::for_each(
            in(std::cin), in(), std::cout << (_1 * 3) << " ");
        return 2;
    }
}




#endif*/