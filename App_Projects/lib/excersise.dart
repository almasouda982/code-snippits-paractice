

import 'package:flutter/material.dart';

class excersise extends StatelessWidget {
  const excersise({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Excersise'),
        backgroundColor: Colors.blue,
      ),
      body: Column(

        crossAxisAlignment: CrossAxisAlignment.center,
        children: [
          Column(),
          Row(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              Text("Got Any Grapes?",
                style: TextStyle(
                  fontSize: 40,
                  color: Colors.purple,
                  fontWeight: FontWeight.bold,
                ),),


            ],

          ),

          GestureDetector(
            onTap: () {
              print('Local Image tapped (Got Any Grapes?)');
            },
            child: Image.asset(
              'assets/Images/annoyingduck.jpg',
              width: 200,
              height: 200,
            ),

          ),
          Column(

          ),
          Row(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              Text("Dark Horse",
                style: TextStyle(
                  fontSize: 40,
                  color: Colors.black,
                  fontWeight: FontWeight.bold,
                ),),


            ],

          ),
          GestureDetector(
            onTap: () {
              print('Network Image tapped');
            },
            child: Image.network(
              'https://images.netdirector.co.uk/gforces-auto/image/upload/w_412,h_309,q_auto,c_fill,f_auto,fl_lossy/auto-client/32e964f4115df80e930c01f8b131a222/dark_horse_banner_og.png',
              width: 200,
              height: 200,
            ),
          ),
          Column()
        ],

      ),



    );
  }
}
