import 'package:flutter/material.dart';

class testing3 extends StatefulWidget {
  const testing3({super.key});

  @override
  State<testing3> createState() => _testing3State();
}

class _testing3State extends State<testing3> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Container Example",
        style: TextStyle(
          fontWeight: FontWeight.bold,
        ),),
      ),
      body: Container(
        decoration: BoxDecoration(
          color: Colors.blue,
          borderRadius: BorderRadius.circular(20)
        ),
        padding: EdgeInsets.all(30),
        margin: EdgeInsets.symmetric(vertical: 100, horizontal: 100),
        child: Text("Hello Padding"),
        


      ),
    );
  }
}
