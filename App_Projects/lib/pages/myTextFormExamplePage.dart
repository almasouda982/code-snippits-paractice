import 'package:flutter/material.dart';

class TextFormExample extends StatelessWidget {
   TextFormExample({super.key , required this.name});
String name;

  @override
  Widget build(BuildContext context) {
    return TextFormField(
      decoration: InputDecoration(
        labelText: "$name",
        enabledBorder: OutlineInputBorder(
          borderSide: BorderSide(
            color: Colors.blue,
            width: 2,
          ),
          borderRadius: BorderRadius.all(Radius.circular(20))
        )
      ) ,
      validator: (value){
        if (value == null || value.isEmpty){
          return "please don't leave the field empty";
        }
        return null;
      },
    );

  }
}
