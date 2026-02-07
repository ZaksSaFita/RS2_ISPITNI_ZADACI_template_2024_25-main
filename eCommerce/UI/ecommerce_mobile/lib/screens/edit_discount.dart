import 'dart:io';

import 'package:ecommerce_mobile/layouts/master_screen.dart';
import 'package:ecommerce_mobile/model/discount.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/providers/discount_provider.dart';
import 'package:ecommerce_mobile/screens/product_discount_list.dart';
import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';

class EditDiscount extends StatefulWidget {
  final Discount? item;
  const EditDiscount(this.item, {super.key});

  // const EditDiscount(this.item, {Key? key}) : super(key: key);

  @override
  State<EditDiscount> createState() => _EditDiscount();
}

class _EditDiscount extends State<EditDiscount> {
  final formKey = GlobalKey<FormBuilderState>();

  bool get isEdit => widget.item != null;

  Map<String, dynamic> _initalValue = {};

  late DiscountProvider discountProvider;

  SearchResult<Discount>? discount;
  bool isLoading = true;

  @override
  void initState() {
    super.initState();
    discountProvider = DiscountProvider();
    if (isEdit) {
      _initalValue = {
        "name": widget.item!.product?.name,
        "code": widget.item!.product?.code,
        "unitOfMeasureId": widget.item!.product?.unitOfMeasureId,
        "productTypeId": widget.item!.product?.productTypeId,
        "price": widget.item!.product?.price?.toString(),
      };
    } else {
      _initalValue = {
        "name": "",
        "code": "",
        "unitOfMeasureId": "",
        "productTypeId": "",
        "price": "",
      };
    }
    print("widget.product");
    print(_initalValue);

    initFormData();
  }

  initFormData() async {
    setState(() {
      isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreen(
      title: isEdit ? "Discount edit" : "Add new Discount",
      child: Column(
        children: [_buildForm(), _buildSaveButton()],
      ),
    );
  }

  Widget _buildSaveButton() {
    return Row(
      children: [
        Expanded(
          child: ElevatedButton(
            onPressed: () async {
              Navigator.of(context).push(
                  MaterialPageRoute(builder: (context) => DiscountScreen()));
            },
            child: Text("Back"),
          ),
        ),
        SizedBox(
          width: 50,
        ),
        Expanded(
          child: ElevatedButton(
            onPressed: () async {
              //   formKey.currentState?.saveAndValidate();
              //   if (formKey.currentState?.validate() ?? false) {
              //     print(formKey.currentState?.value.toString());
              //     var request = Map.from(formKey.currentState?.value ?? {});
              //   }
            },
            child: Text("Save"),
          ),
        ),
      ],
    );
  }

  Widget _buildForm() {
    if (isLoading) {
      return Center(child: CircularProgressIndicator());
    }

    return FormBuilder(
        key: formKey,
        initialValue: _initalValue,
        child: Padding(
          padding: const EdgeInsets.all(16.0),
          child: Column(
            children: [
              FormBuilderTextField(
                name: "name",
                decoration: InputDecoration(labelText: "Name"),
              ),
              FormBuilderTextField(
                name: "code",
                decoration: InputDecoration(labelText: "Code"),
              ),
              Row(
                children: [],
              ),
              FormBuilderTextField(
                name: "price",
                decoration: InputDecoration(labelText: "Price"),
              ),
            ],
          ),
        ));
  }
}
