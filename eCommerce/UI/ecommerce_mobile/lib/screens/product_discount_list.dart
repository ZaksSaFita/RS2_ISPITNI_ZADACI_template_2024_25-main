import 'package:ecommerce_mobile/layouts/master_screen.dart';
import 'package:ecommerce_mobile/model/discount.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/providers/discount_provider.dart';
import 'package:ecommerce_mobile/providers/utils.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';

class DiscountScreen extends StatefulWidget {
  const DiscountScreen({super.key});

  @override
  State<DiscountScreen> createState() => _DiscountScreen();
}

class _DiscountScreen extends State<DiscountScreen> {
  late DiscountProvider discountProvider;

  TextEditingController searchController = TextEditingController();

  SearchResult<Discount>? data;

  @override
  void didChangeDependencies() {
    super.didChangeDependencies();
  }

  @override
  void initState() {
    super.initState();
    discountProvider = DiscountProvider();

    loadData(null);
  }

  void loadData(String? input) async {
    var result = await discountProvider.get(filter: {
      "fts": input,
    });
    this.data = result;

    if (result.items != null && result.items!.isNotEmpty) {
      for (var element in result.items!) {
        print("itemi: ${element.product!.name}");
      }
    }

    setState(() {});
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreen(
      title: "Discount List",
      child: Center(
        child: Column(
          children: [
            _buildSearch(),
          ],
        ),
      ),
    );
  }

  Widget _buildSearch() {
    return Padding(
      padding: const EdgeInsets.all(8.0),
      child: Row(
        children: [
          SearchBar(
            controller: searchController,
            hintText: "Search by ProductName",
            onChanged: (value) async {
              loadData(value);
            },
          ),
          SizedBox(
            width: 30,
          ),
          Expanded(
            child: ElevatedButton.icon(
              onPressed: () async {},
              label: Text("Add new Discount"),
              icon: Icon(Icons.add),
            ),
          )
        ],
      ),
    );
  }
}
