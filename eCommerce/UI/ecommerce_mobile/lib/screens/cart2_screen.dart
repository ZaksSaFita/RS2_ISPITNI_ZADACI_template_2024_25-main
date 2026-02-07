import 'package:ecommerce_mobile/layouts/master_screen.dart';
import 'package:ecommerce_mobile/model/cart_provider.dart';
import 'package:ecommerce_mobile/model/cart.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/model/shop.dart';
import 'package:ecommerce_mobile/providers/auth_provider.dart';
import 'package:ecommerce_mobile/providers/shop_provider.dart';
import 'package:ecommerce_mobile/providers/utils.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class Cart2Screen extends StatefulWidget {
  const Cart2Screen({super.key});

  @override
  State<Cart2Screen> createState() => _Cart2ScreenState();
}

class _Cart2ScreenState extends State<Cart2Screen> {
  late ShopProvider shopProvider;
  var userId;
  ShopCart? cart;
  @override
  void initState() {
    super.initState();
    shopProvider = ShopProvider();
    userId = AuthProvider.user?.id;
    loadData();
  }

  loadData() async {
    var result = await shopProvider.get(filter: {"userId": userId});
    if (result.items != null && result.items!.isNotEmpty) {
      cart = result.items!.first;
    }
    setState(() {});
  }

  @override
  Widget build(BuildContext context) {
    if (cart == null || cart!.cartItems == null || cart!.cartItems!.isEmpty) {
      return MasterScreen(
        title: "Shopping Cart",
        child: Center(
          child: Column(
            children: [Text("no data ...")],
          ),
        ),
      );
    }
    return MasterScreen(
      title: "Shopping Cart",
      child: Center(
        child: Column(
          children: [
            _buildCartHeader(),
            _buildCartItems(),
            _buildCartSummary(),
          ],
        ),
      ),
    );
  }

  Widget _buildCartHeader() {
    return Padding(
      padding: const EdgeInsets.all(16.0),
      child: Row(
        children: [
          Icon(Icons.shopping_cart, size: 24),
          SizedBox(width: 8),
          Text(
            "Cart Items (${cart?.cartItems?.length})",
            style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
          ),
        ],
      ),
    );
  }

  Widget _buildCartItems() {
    if (cart == null || cart!.cartItems!.isEmpty) {
      return Expanded(
        child: Center(
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              Icon(Icons.shopping_cart_outlined, size: 64, color: Colors.grey),
              SizedBox(height: 16),
              Text(
                "Your cart is empty",
                style: TextStyle(fontSize: 18, color: Colors.grey),
              ),
            ],
          ),
        ),
      );
    }

    return Expanded(
      child: ListView.builder(
        itemCount: cart?.cartItems?.length,
        itemBuilder: (context, index) {
          final item = cart!.cartItems![index];
          return _buildCartItemCard(item);
        },
      ),
    );
  }

  Widget _buildCartItemCard(ShopItem item) {
    return Card(
      margin: EdgeInsets.symmetric(horizontal: 16, vertical: 8),
      child: Padding(
        padding: EdgeInsets.all(12),
        child: Row(
          children: [
            // Product Image
            Container(
              height: 80,
              width: 80,
              child: item.product!.assets.firstOrNull == null
                  ? Placeholder()
                  : imageFromString(item.product!.assets.first.base64Content),
            ),
            SizedBox(width: 12),
            // Product Details
            Expanded(
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(
                    item.product!.name,
                    style: TextStyle(
                      fontSize: 16,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                  SizedBox(height: 4),
                  Text(
                    formatNumber(item.product!.price),
                    style: TextStyle(
                      fontSize: 14,
                      color: Colors.green,
                      fontWeight: FontWeight.w500,
                    ),
                  ),
                  SizedBox(height: 8),
                  Row(
                    children: [
                      Text("Quantity: "),
                      Text(
                        "${item.quantity}",
                        style: TextStyle(fontWeight: FontWeight.bold),
                      ),
                    ],
                  ),
                ],
              ),
            ),
            // Actions
            // Column(
            //   children: [
            //     Text(
            //       formatNumber((item.product.price ?? 0.0) * item.count),
            //       style: TextStyle(
            //         fontSize: 16,
            //         fontWeight: FontWeight.bold,
            //         color: Colors.green,
            //       ),
            //     ),
            //     SizedBox(height: 8),
            //     IconButton(
            //       onPressed: () {
            //         cartProvider.removeFromCart(item.product);
            //       },
            //       icon: Icon(Icons.delete, color: Colors.red),
            //     ),
            //   ],
            // ),
          ],
        ),
      ),
    );
  }

  Widget _buildCartSummary() {
    if (cart!.cartItems!.isEmpty) {
      return SizedBox.shrink();
    }

    double total = cart!.cartItems!
        .map((item) => (item.product!.price ?? 0.0) * item.quantity)
        .reduce((a, b) => a + b);
    //double total = 10;
    return Container(
      padding: EdgeInsets.all(16),
      decoration: BoxDecoration(
        color: Colors.grey[100],
        border: Border(top: BorderSide(color: Colors.grey[300]!)),
      ),
      child: Column(
        children: [
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Text(
                "Total:",
                style: TextStyle(
                  fontSize: 18,
                  fontWeight: FontWeight.bold,
                ),
              ),
              Text(
                formatNumber(total),
                style: TextStyle(
                  fontSize: 20,
                  fontWeight: FontWeight.bold,
                  color: Colors.green,
                ),
              ),
            ],
          ),
          SizedBox(height: 16),
          SizedBox(
            width: double.infinity,
            child: ElevatedButton(
              onPressed: () {
                // TODO: Implement checkout functionality
                ScaffoldMessenger.of(context).showSnackBar(
                  SnackBar(
                      content:
                          Text("Checkout functionality not implemented yet")),
                );
              },
              style: ElevatedButton.styleFrom(
                padding: EdgeInsets.symmetric(vertical: 16),
                backgroundColor: Colors.blue,
                foregroundColor: Colors.white,
              ),
              child: Text(
                "Proceed to Checkout",
                style: TextStyle(fontSize: 16, fontWeight: FontWeight.bold),
              ),
            ),
          ),
        ],
      ),
    );
  }
}
