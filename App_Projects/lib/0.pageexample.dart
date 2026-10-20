// state less or state full two widges types

import 'package:flutter/material.dart';

class Test1 extends StatelessWidget {
  const Test1({super.key});

  @override
  Widget build(BuildContext context) {
    return  Directionality(
      textDirection: TextDirection.ltr,
      child: Scaffold(
        drawer: Drawer(),
        appBar: AppBar(
          title: Text('First App'),
          backgroundColor: Colors.blue,
        ),
        body: Container(
          color: Colors.brown,
        ),
        floatingActionButton:Container(
          color: Colors.amber,
          width: 50,
          height: 50,
        ) ,
        bottomNavigationBar:Container(
          color: Colors.red,

          height: 80,
        )  ,


      ),
    );
  }
  }
