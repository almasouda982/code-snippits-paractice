import 'package:flutter/material.dart';

class testing5 extends StatefulWidget {
  const testing5({super.key});

  @override
  State<testing5> createState() => _testing5State();
}

class _testing5State extends State<testing5> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      // appBar: AppBar(
      //   title: Text("Image"),
      // ),
      // body: Center(
      //   child: Image.asset("assets/Images/annoyingduck.jpg"),
      // ),
      appBar: AppBar(
        backgroundColor: Colors.blue,
        title: Text("Image Network"),
      ),
      
      body: Center(
        child: Image.network("https://tse4.mm.bing.net/th/id/OIP.nfMCPiNc8h6zsD-Iry_7FwHaE8?r=0&rs=1&pid=ImgDetMain&o=7&rm=3",
        width: 300, height: 200,
        ),

      ),
    );
  }
}
