import 'package:flutter/material.dart';

class testing4 extends StatefulWidget {
  const testing4({super.key});

  @override
  State<testing4> createState() => _testing4State();
}

class _testing4State extends State<testing4> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Colors.blue,
        title: Center(
          child: Text("Container Example"),
        )
      ),
      body: Center(
        child: Container(
          width: 200,
          height: 200,
          decoration: BoxDecoration(
            color: Colors.blue,
            borderRadius: BorderRadius.circular(20),
            gradient: LinearGradient(
                colors: [
                  Colors.blue,
                  Colors.green,
                ]
            ),
            boxShadow: [
              BoxShadow(
                color: Colors.red,
                blurRadius: 10.0,
                offset: Offset(7, 7),
              ),

              BoxShadow(
                color: Colors.deepOrangeAccent,
                blurRadius: 10.0,
                offset: Offset(-7, -7),
              )

            ]
          ),
        ),
      ),
    );
  }
}
