#include <iostream>
#include <fstream>
#include <cstring>
#include <experimental/filesystem>
#include "imageTest.h"
//#include "sample.h"

using namespace std;
// function definition
int getImage(char* path, char* buffer) {
    ifstream in;
    cout << path << endl;
    in.open(path, ios::binary | ios::in);
    if (in.is_open()) {
        cout << "Open Success" << endl;
        //get length of file
        in.seekg(0, std::ios::end);
        size_t length = in.tellg();
        cout << length << endl;
        in.seekg(0, std::ios::beg);
        in.read(buffer, length);
        in.close();
    } else {
        cout << "Open Failed" << endl;
        return 1;
    }
    return 0;
}