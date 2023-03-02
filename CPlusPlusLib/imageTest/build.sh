#if [ -s "build/libshared.so" ] 
#then
    #rm build/libshared.so
#fi

if [ ! -d "build" ] 
then
    mkdir build
fi

#-fPIC 作用於編譯階段，告訴編譯器產生與位置無關代碼(Position-Independent Code)， 
#則產生的代碼中，沒有絕對地址，全部使用相對地址，故而代碼可以被加載器加載到內存的任意位置，
#都可以正確的執行。這正是共享庫所要求的，共享庫被加載時，在內存的位置不是固定的。
#PIC就是position independent code
#PIC使.so文件的代碼段變為真正意義上的共享
if [ ! -d "build/x86" ] 
then
    mkdir build/x86
fi
g++ -shared -fPIC -o build/x86/libimagetest.so imageTest.cpp -lstdc++fs
#gcc -shared -fPIC -o libimagetest.so imageTest.cpp

if [ ! -d "build/aarch64" ] 
then
    mkdir build/aarch64
fi
aarch64-linux-gnu-g++ -fPIC -shared -o build/aarch64/libimagetest.so imageTest.cpp