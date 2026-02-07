import 'package:ecommerce_mobile/layouts/master_screen.dart';
import 'package:ecommerce_mobile/model/product.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/model/user_favorite.dart';
import 'package:ecommerce_mobile/providers/auth_provider.dart';
import 'package:ecommerce_mobile/providers/favorite_provider.dart';
import 'package:ecommerce_mobile/providers/utils.dart';
import 'package:ecommerce_mobile/screens/product_list.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

class ProductDetails extends StatefulWidget {
  final Product? x;
  const ProductDetails(this.x, {super.key});

  @override
  State<ProductDetails> createState() => _ProductDetails();
}

class _ProductDetails extends State<ProductDetails> {
  late FavoriteProvider favoriteProvider;
  var productId;
  var userId;
  SearchResult<UserFavorite>? data;
  bool isFavorite = false;
  @override
  void initState() {
    super.initState();
    favoriteProvider = FavoriteProvider();
    productId = widget.x?.id;
    userId = AuthProvider.user?.id;
    loadData();
  }

  loadData() async {
    data = await favoriteProvider.get(filter: {"productId": productId});

    if (data!.items != null && data!.items!.isNotEmpty) {
      print("${data?.items?.first.id}");
      isFavorite = true;
    }
    setState(() {});
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreen(
        title: "Product Details",
        child: Center(
          child: Column(
            children: [_buildCard()],
          ),
        ));
  }

  Widget _buildCard() {
    return Container(
      width: 600,
      height: 600,
      child: Card(
        margin: EdgeInsets.symmetric(horizontal: 16, vertical: 8),
        child: Padding(
          padding: EdgeInsets.all(12),
          child: Column(
            children: [
              // Product Image
              Expanded(
                child: Container(
                  // height: 80,
                  // width: 80,
                  child: widget.x?.assets.firstOrNull == null
                      ? Placeholder()
                      : imageFromString(widget.x!.assets.first.base64Content),
                ),
              ),
              SizedBox(width: 12),
              // Product Details
              Expanded(
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Text("Name: "),
                    Text(
                      widget.x!.name,
                      style: TextStyle(
                        fontSize: 16,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                    SizedBox(height: 4),
                    Text("Price: "),
                    Text(
                      "${formatNumber(widget.x!.price)} \$ / ${widget.x!.unitOfMeasure!.name}",
                      style: TextStyle(
                        fontSize: 14,
                        color: Colors.green,
                        fontWeight: FontWeight.w500,
                      ),
                    ),
                    SizedBox(height: 8),
                    Text("Type: "),
                    Text(
                      "${widget.x!.productType!.name}",
                      style: TextStyle(fontWeight: FontWeight.bold),
                    ),
                    SizedBox(height: 8),
                    Text("Description: "),
                    Text(
                      "${widget.x!.description}",
                      style: TextStyle(fontWeight: FontWeight.bold),
                    ),
                  ],
                ),
              ),

              Column(
                children: [
                  IconButton(
                      onPressed: () async {
                        var request = {
                          "productId": productId,
                          "userId": userId,
                        };
                        if (isFavorite) {
                          await favoriteProvider
                              .delete(data!.items!.first.id)
                              .then((_) {
                            Navigator.of(context).push(MaterialPageRoute(
                                builder: (context) => ProductList()));
                          });
                        } else {
                          await favoriteProvider.insert(request).then((_) {
                            Navigator.of(context).push(MaterialPageRoute(
                                builder: (context) => ProductList()));
                          });
                          ;
                        }
                      },
                      icon: isFavorite
                          ? Icon(Icons.favorite, color: Colors.red)
                          : Icon(Icons.favorite_outline, color: Colors.green)),
                ],
              ),
            ],
          ),
        ),
      ),
    );
  }
}
