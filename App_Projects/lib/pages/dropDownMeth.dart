import 'package:flutter/material.dart';

class DropDown extends StatefulWidget {
   DropDown({super.key ,
     required this.selecteValue,
     required this.items
   });
   String? selecteValue;
   List<String> items;

  @override
  State<DropDown> createState() => _DropDownState();
}

class _DropDownState extends State<DropDown> {
  String? _selectedValue;
  @override
  Widget build(BuildContext context) {
    return DropdownButton<String>(
      hint: const Text('Select option'),
      value: _selectedValue,
      items: <String>['option1', 'option2', 'option3']
          .map<DropdownMenuItem<String>>((String value) {
        return DropdownMenuItem(value: value, child: Text(value));
      }).toList(),
      onChanged: (String? value) {
        setState(() {
          _selectedValue = value;
        });
      },
    );
  }
}
