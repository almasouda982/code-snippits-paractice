import 'package:flutter/material.dart';

class testing8 extends StatefulWidget {
  const testing8({super.key});

  @override
  State<testing8> createState() => _testing8State();
}

class _testing8State extends State<testing8> {
  int counter = 1;

  void increment(){
    setState(() {
      counter ++;
    });
  }
  void decrement(){
    setState(() {
      counter --;
    });
  }


  @override
  void setState(VoidCallback fn) {
    // TODO: implement setState
    super.setState(fn);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("StatFullWidget"),
        backgroundColor: Colors.blue,

      ),

      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Text("Counter Value: ",style: TextStyle(
              fontSize: 20
            ),
            ),

            Text("$counter",
            style: TextStyle(
              fontSize: 20
            ),
            ),
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  ElevatedButton(onPressed: increment, child: Text("+")),
                  SizedBox(width: 20,),
                  
                  ElevatedButton(onPressed: decrement, child: Text("-")),
                  SizedBox(width: 20,)
                  
                ],
            )
          ],
        ),
      ),
    );
  }
}
