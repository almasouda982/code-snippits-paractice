import 'package:flutter/material.dart';

class testpage extends StatefulWidget {
  const testpage({super.key});

  @override
  State<testpage> createState() => _testpageState();
}

class _testpageState extends State<testpage> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      drawer: Drawer(),
      appBar: AppBar(
        title: Text("FIRST APP"),
        backgroundColor: Colors.blue,
      ),
      body: Container(
        color: Colors.brown,
        child: Text("My Home",
        style: TextStyle(
          fontSize: 40
        ),),

      ),
      floatingActionButton: Container(
        color: Colors.amber,
        width: 50,
        height: 50,
      ),
      bottomNavigationBar: Container(
        color: Colors.red,

        height: 80,
      ),
    );
  }
}
